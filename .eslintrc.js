module.exports = {
  extends: [
    'eslint-config-semistandard'
  ],
  overrides: [
    {
      files: ['*.js', 'lib/*.js'],
      excludedFiles: [
        '*.test.js'
      ],
      rules: {
        quotes: ['error', 'single'],
        semi: ['error', 'always']
      }
    }
  ]
};
