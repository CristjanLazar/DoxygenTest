const core = require('@actions/core');
const fs = require('fs');

try {
  // get path
  const path = core.getInput('path'); //`docs/SYE`
  console.log(`Path is ${path}`);

  // write file
  const fileName = core.getInput(`shortcut-name`); //`Live 1.1 SYE - Technical Document`
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