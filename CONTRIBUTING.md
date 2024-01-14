# Contributing Guide

This document shows you how to get started contributing to this project.

## Submitting changes

- Fork the repository.
    - Click on the fork button. ![](./docs/images/code_fork_button.png)
    - Validate the fork creation. ![](./docs/images/create_fork_button.png)
- Clone your fork by **HTTPS** or **SSH** method (as you prefer).
  ```shell
  # With HTTPS method
  https://github.com/MyName/template.git
  
  # With SSH method
  git clone git@github.com:MyName/template.git
  ```
  ![](./docs/images/fork_clone_button.png)
- Check out a new branch based and name it to what you intend to do:
  > Use one branch per fix / feature
    - Example:
      ```shell
      git checkout -b feat/BRANCH_NAME
      git checkout -b fix/BRANCH_NAME
      ```
- Commit your changes
    - Please provide a git message that explains what you've done.
    - Please make sure your commits follow the [conventions](https://www.conventionalcommits.org/).
    - Commit to the remote repository.
    - Example:
      ```shell
      git commit -am 'feat(plugin): add a commit message'
      ```

      ```mermaid
        gitGraph
            commit
            commit
            branch feat/filter
            commit
            commit
            checkout main
            commit
            commit
      ```

- Push your changes to your fork.
    - Example:
      ```shell
      git push origin BRANCH_NAME
      ```

- Make a pull request **when you are done with your changes**. ![](./docs/images/fork_create_pull_request.png)
    - Make sure you send the PR to the `main` branch.
        - **title** should follow the same convention as your commits.
        - **description** should follow the template (if exists) or be as descriptive as
          possible. ![](./docs/images/fork_create_pull_request_validation.png)
    - [GitHub Actions](https://docs.github.com/en/actions) are watching you!

If you follow these instructions, your PR will land pretty safely in the main repository!

```mermaid
gitGraph
    commit
    commit
    branch feat/filter
    commit
    commit
    checkout main
    commit
    checkout feat/filter
    merge main id: "merge main into feat/filter"
    checkout main
    merge feat/filter id: "merge feat/filter into main"
```
