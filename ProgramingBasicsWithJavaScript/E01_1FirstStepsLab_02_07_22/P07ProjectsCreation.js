function projects(input) {
    let hourNeededForProject = Number(3);
    let nameOfArchitect = (input[0]);
    let numberOfProjects = Number(input[1]);
    let result = numberOfProjects * hourNeededForProject;
    console.log(`The architect ${nameOfArchitect} will need ${result} hours to complete ${numberOfProjects} project/s.`);
}

projects(["George ", "4 "]);