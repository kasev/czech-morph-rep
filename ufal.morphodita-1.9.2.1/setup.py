from distutils.core import setup, Extension

with open('README') as file:
    readme = file.read()

setup(
    name             = 'ufal.morphodita',
    version          = '1.9.2.1',
    description      = 'Bindings to MorphoDiTa library',
    long_description = readme,
    author           = 'Milan Straka',
    author_email     = 'straka@ufal.mff.cuni.cz',
    url              = 'http://ufal.mff.cuni.cz/morphodita',
    license          = 'MPL 2.0',
    py_modules       = ['ufal.morphodita'],
    ext_modules      = [Extension(
        'ufal_morphodita',
        ['morphodita/morphodita.cpp', 'morphodita/morphodita_python.cpp'],
        language = 'c++',
        include_dirs = ['morphodita/include'],
        extra_compile_args = ['-std=c++11', '-fvisibility=hidden', '-w'])],
    classifiers = [
        'Development Status :: 5 - Production/Stable',
        'License :: OSI Approved :: Mozilla Public License 2.0 (MPL 2.0)',
        'Programming Language :: C++',
        'Programming Language :: Python',
        'Programming Language :: Python :: 2',
        'Programming Language :: Python :: 3',
        'Topic :: Software Development :: Libraries'
    ]
)
