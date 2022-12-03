const WebSocket = require('ws');

require('dotenv').config();

const port = process.env.PORT || 8080;
const wss = new WebSocket.Server({ port }, () => {
  console.log('server started');
});

wss.on('connection', function connection (ws) {
  ws.on('message', (data) => {
    console.log('data received \n %o', data);
    ws.send(data);
  });
});

wss.on('listening', () => {
  console.log(`listening on ${port}`);
});

wss.on('disconnect', () => {
  console.log('A player was disconnected');
});
