$(function () {
    $('.save-button').on('click', saveAll);
})


function saveAll() {
    let path = createPath();
    let postData = [];

    let $editors = $('.content-container').children('.editor');

    for (let i = 0; i < $editors.length; i++) {
        postData[i] = createCodeDataObject($($editors[i]), i);
    }

    console.log(postData);

    $.ajax({
        url: path,
        type: 'POST',
        data: JSON.stringify(postData),
        contentType: "application/json",
        success: function (data) {
            // TODO: Реализовать.
        },
        error: function (data) {
            // TODO: Реализовать.
        }
    });
}


// Формирование пути запроса.
function createPath() {
    let searchParams = new URLSearchParams(location.search);

    let latShortName = searchParams.get('article');
    let seqNum = searchParams.get('chapter') ?? '0';

    return `api/editor?latShortName=${latShortName}&seqNum=${seqNum}`;
}



// Формирование данных запроса.
function createCodeDataObject($editor, seqNum) {
    let id = $editor.attr('item-id');
    if (id === undefined || id === "") id = 0;

    if ($editor.hasClass('subtitle-editor')) {
        let content = $editor.find('.content-area').val();
        return {Id: id, SeqNum: seqNum, TypeCode: "subtitleAnchor", Content: content}
    }
    else if ($editor.hasClass('text-editor')) {
        let content = $editor.find('content-area').html();
        return {Id: id, SeqNum: seqNum, TypeCode: "formattedText", Content: content};
    }
    else if ($editor.hasClass('code-editor')) {
        let lang = $editor.find('.lang-select option:selected').val();
        let content = $editor.find('.content-area').val();

        return {Id: id, SeqNum: seqNum, TypeCode: lang, Content: content};
    }
    else if ($editor.hasClass('note-editor')) {
        let content = $editor.find('.content-area').html();
        return {Id: id, SeqNum: seqNum, TypeCode: "formattedNote", Content: content};
    }
    else return null;
}