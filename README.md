 Basic Setup Instructions
 
    # Install brew
    ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"

    brew tap aspnet/dnx
    brew update

    # add to ~/.bash_profile   
    source dnvm.sh
    # and reload bash with the new profile
    . ~/.bash_profile
    
    brew install dnvm
    dnvm upgrade
    
    npm install -g yo gulp
    npm install -g generator-aspnet

    yo aspnet --gulp
    # will create a new folder
    # and then follow the instructions
    
When you modify the packages list in `project.json` you should run `dnu restore` to get the latest ones. Enjoy!