// This file is part of MorphoDiTa <http://github.com/ufal/morphodita/>.
//
// Copyright 2016 Institute of Formal and Applied Linguistics, Faculty of
// Mathematics and Physics, Charles University in Prague, Czech Republic.
//
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

#include "gru_tokenizer.h"
#include "gru_tokenizer_factory.h"
#include "utils/binary_decoder.h"
#include "utils/compressor.h"

namespace ufal {
namespace morphodita {

tokenizer* gru_tokenizer_factory::new_tokenizer() const {
  return new gru_tokenizer(url_email_tokenizer, segment, *network);
}

bool gru_tokenizer_factory::load(istream& is) {
  char version;
  if (!is.get(version)) return false;

  binary_decoder data;
  if (!compressor::load(is, data)) return false;

  try {
    url_email_tokenizer = data.next_1B();
    segment = data.next_2B();

    network.reset(gru_tokenizer_network::load(data));
    if (!network) return false;
  } catch (binary_decoder_error&) {
    return false;
  }

  return data.is_end();
}

} // namespace morphodita
} // namespace ufal
