const shortID = require('shortid');

class Player {
  constructor () {
    this.username = '';
    this.id = shortID.generate();
  }
}

module.exports = { Player };
