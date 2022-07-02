$(function () {
    $('.add-article-button').on('click', function () {
        $('.articles-container').append(articlePanel);
    });


    $(document).on('click', '.save-article-button', function () {
        let $panel = $(this).closest('.article-panel');
        let postData = CreateDataObject($panel);
        SaveArticle($panel, postData);
    });

    $(document).on('click', '.delete-article-button', function () {
        let $panel = $(this).closest('.article-panel');
        let latShortName = $panel.find('.article-lat-name').text();
        DeleteArticle($panel, latShortName);
    });
})



// Сохранение данных статьи.
function SaveArticle($panel, postData) {
    let path = 'api/author';

    $.ajax({
        url: path,
        type: 'POST',
        data: JSON.stringify(postData),
        contentType: "application/json",
        success: function (data) {
            $panel.find('.panel-edit').hide();
        },
        error: function (data) {
            // TODO: Реализовать.
        }
    });
}


// Удаление статьи.
function DeleteArticle($panel, latShortName) {
    let path = `api/author?latShortName=${latShortName}`;

    $.ajax({
        url: path,
        type: 'DELETE',
        contentType: "application/json",
        success: function () {
            $panel.remove();
        },
        error: function (data) {
            // TODO: Реализовать.
        }
    });
}


// Формирование данных запроса.
function CreateDataObject($panel) {
    let id = $panel.find('.article-id-input').val();
    let name = $panel.find('.article-name-input').val();
    let latName = $panel.find('.article-lat-name-input').val();
    let description = $panel.find('.article-description-input').val();

    return { Id: id, LatShortName: latName, Name: name, Description: description };
}



const articlePanel = `<div class="article-panel">
    <div class="panel-edit">
        <input class="article-id-input" type="text" hidden />
        <input class="article-name-input" type="text" placeholder="Основы языка C#" />
        <input class="article-lat-name-input" type="text" placeholder="csharp-basics" />
        <textarea class="article-description-input" placeholder="Описание статьи"></textarea>
        <input class="save-article-button" type="button" value="save" />
    </div>
    <div class="chapter-panels-container"></div>
    <div class="panel-content">
        <p class="article-name"></p>
        <p class="article-lat-name"></p>
        <p class="article-description"></p>
        <input class="edit-article-button" type="button" value="edit" />
        <input class="delete-article-button" type="button" value="delete" />
    </div>
</div>`;