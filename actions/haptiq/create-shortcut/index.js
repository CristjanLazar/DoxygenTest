const core = require('@actions/core');
const fs = require('fs');

try {
  const projectId = `SYE`;

  // get path
  const path = `docs/SYE` //core.getInput('path');
  console.log(`Path is ${path}`);

  // write file
  const fileName = `Live 1.1 SYE - Technical Document` //core.getInput(`file-name`);
  const fullPath = `${path}/${fileName}.html`;
  const fileData = `<meta http-equiv="REFRESH" content="0;URL=html/index.html">`;
  console.log(`File name is ${fileName}`);
  console.log(`Full path is ${fullPath}`);
  console.log(`FileData is ${fileData}`);
  fs.writeFile(`${fullPath}`, fileData, err => {
    if (err) return console.log(err);
    console.log(`File created at ${fullPath}!`);
  });
} 

catch (error) {
  core.setFailed(error.message);
}