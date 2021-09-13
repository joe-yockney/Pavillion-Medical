/* _layout js */
var isOpen = true;

function toggleSidebar() {
    if (isOpen) {
        document.getElementById("mySidenav").style.width = "300px";
        this.isOpen = false;
    }
    else {
        document.getElementById("mySidenav").style.width = "70px";
        this.isOpen = true;
    }
}

function openNav() {
    document.getElementById("mySidenavTwo").style.width = "250px";
    isOpen = true;
}

function closeNav() {
    document.getElementById("mySidenavTwo").style.width = "0px";
}

/* Explore js */

var isOpen = true;

function toggleMoreInfo() {
    if (isOpen) {
        document.getElementById("more-info").style.height = "200px";
        this.isOpen = false;
    }
    else {
        document.getElementById("more-info").style.height = "0px";
        this.isOpen = true;
    }

}
var isOpen = true;