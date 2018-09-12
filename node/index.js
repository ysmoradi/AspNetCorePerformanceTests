const express = require('express');
const app = express();

app.get('/api/values/:id/', (req, res) => {
    res.send(req.params.id);
});

app.listen(5000, () => console.log('Example app listening on port 5000!'));
