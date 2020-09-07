const core = require('@actions/core');
const fs = require('fs');

try {
  // inputs
  const projectId = core.getInput('project-id'); //`SYE`
  const path = `./docs/${projectId}`;
  console.log(`Path is ${path}`);
  
  // create directory
  fs.mkdirSync(path, { recursive: true });

  // output path
  core.setOutput('path', path);
} 

catch (error) {
  core.setFailed(error.message);
}