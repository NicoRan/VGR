
$(document).ready(() => {
    console.log('vatre');
    $('#show-hide-comment').on('click', function (event) {
        console.log(event);
        let button = document.getElementById('show-hide-comment');
        let divHolder = document.getElementById('comment-show');
        console.log(divHolder);
        if (divHolder.style.display === 'none') {
            divHolder.style.display = "initial";
            button.textContent = 'Cancel Comment';
        }
        else {
            divHolder.style.display = "none";
            button.textContent = 'Add Comment';
        }
    });
});
