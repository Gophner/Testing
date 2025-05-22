# Tutorial: Intro to Unity and CLI to github

## Overview

This repo has the code for a tutorial unity project and details on how to use github through the command line

## Command Line Github

You first need to set up an ssh key to your github. Then, you want to clone the repo. This link https://www.geeksforgeeks.org/using-github-with-ssh-secure-shell/ details these steps

For command line users, you can use the following command to clone the repo:

```bash
git clone git@github.com:dineshghimire01/REU-Summer-2024-Cornell.git
```

For keeping the cloned repo in sync with the original repo, you can follow the steps below:

```bash
git fetch origin
git checkout main
git pull
```

For writing your changes while working on the `main` branch:

```bash
# this will show the files you have changed
git status 
# based on the file names that were modified above
# you can choose which files to update in a 'commit' individually
# or all at once.
# For all files at once (not generally recomended)
# git add . 
# For individual files
git add <file_name>
# commit the changes
git commit -m "Your commit message here"
# push the changes to the remote repository
git push
# or git push origin


```

## Bonus git commands

To know the status of the current branch, you can use the following command:

```bash
git status
```

To know changes which changes have been made to the files, you can use the following command:

```bash
# to see all the changes
git diff
# or to see the changes in a specific file
git diff <file_name>

```

If you want to create a new branch and work on it, you can use the following commands:

```bash

# create a new branch
git checkout -b <branch_name>
# push the new branch to the remote repository
git push -u origin <branch_name>

```

If you want to switch to an existing branch, you can use the following command:

```bash
git checkout <branch_name>
```

To list branches, you can use the following command:

```bash
git branch
```
