$(function () {
    $('.content-container').sortable({ cancel: 'input, textarea, select, img, p, [contentEditable]' });


    $('.add-subtitle-editor-button').on('click', function () {
       $('.content-container').append(subtitleEditor);
    });

    // Добавление редактора текста.
    $('.add-text-editor-button').on('click', function () {
        $('.content-container').append(textEditor);
    });

    // Добавление редактора кода.
    $('.add-code-editor-button').on('click', function () {
        $('.content-container').append(codeEditor);
    });

    // Добавление редактора примечания.
    $('.add-note-editor-button').on('click', function () {
        $('.content-container').append(noteEditor);
    });


    // Удаление редактора содержимого.
    $(document).on('click', '.editor-remove-button', function () {
       $(this).closest('.editor').remove();
    });


    // Открытие поля создания ссылок.
    $(document).on('click', '.add-link-button', function () {
       let $buttonContainer = $(this).closest('.buttons-container');
       $buttonContainer.find('.link-item-container').css("visibility", "inherit");
    });


    // Подтверждение создания ссылки в форматированном тексте.
    $(document).on('click', '.save-link-button', function () {
        let $buttonContainer = $(this).closest('.buttons-container');

        let $hrefInput = $buttonContainer.find('.href-input');

        let linkUrl = $hrefInput.val();
        let selection = document.getSelection();

        if (linkUrl !== '') {
            document.execCommand('insertHTML', false, `<a href="${linkUrl} target="_black">${selection}</a>`);
            $hrefInput.val('');
            $buttonContainer.find('.link-item-container').css("visibility", "hidden");
        }
    });


    // Отмена создания ссылки в форматированном тексте.
    $(document).on('click', '.cancel-link-button', function () {
        let $buttonContainer = $(this).closest('.buttons-container');
        $buttonContainer.find('.link-item-container').css("visibility", "hidden");
    });


    // Выделение текста жирным.
    $(document).on('click', '.bold-button', function () {
        document.execCommand('bold', false, null);
    });

    // Подчеркивание текста.
    $(document).on('click', '.underline-button', function () {
        document.execCommand('underline', false, null);
    });

    // Зачеркивание текста.
    $(document).on('click', '.strikethrough-button', function () {
        document.execCommand('strikethrough', false, null);
    });

    // Выделение кода в текста.
    $(document).on('click', '.code-style-button', function () {
        let selection = document.getSelection();
        document.execCommand('insertHTML', false, `<span class="code">${selection}</span>`);
    });
})



const subtitleEditor = `<div class="subtitle-editor editor">
    <div><input class="content-area" type="text" /></div>
    <input class="editor-remove-button" type="button" value="delete" />
</div>`;


const textEditor = `<div class="text-editor editor">
    <div class="text-editor-header">
        <div class="buttons-container">
            <img class="editor-button bold-button" src="/root/icons/bold-black.svg" alt="Жирный" />
            <img class="editor-button underline-button" src="/root/icons/underline-black.svg" alt="Подчеркнутый" />
            <img class="editor-button strikethrough-button" src="/root/icons/strikethrough-black.svg" alt="Зачеркнутый" />
            <img class="editor-button code-style-button" src="/root/icons/code-black.svg" alt="Выделение" />
        </div>
        <div class="remove-button-container">
            <img class="editor-remove-button" src="/root/icons/remove-black.svg" alt="Удалить" />
        </div>
    </div>
    <div class="text-editor-content">
        <div contenteditable="true" class="content-editable content-area"></div>
    </div>
</div>`;


const codeEditor = `<div class="code-editor editor">
    <div class="code-editor-header">
        <select class="lang-select">
            <option value="_default">Не выбрано</option>
            <option value="aspx-csharp">ASP.NET (C#) (.aspx, .ascx)</option>
            <option value="css">CSS таблица стилей (.css)</option>
            <option value="csharp">C# — C Sharp (.cs)</option>
            <option value="fsharp">F# — F Sharp (.fs)</option>
            <option value="html">HTML разметка (.html)</option>
            <option value="javascript">Javascript (.js)</option>
            <option value="cshtml-razor">Razor Pages (.cshtml)</option>
            <option value="scss">SCSS таблица стилей (.scss)</option>
            <option value="sql">Transact-SQL (.sql)</option>
            <option value="typescript">TypeScript (.ts)</option>
        </select>
        <div class="remove-button-container">
            <img class="editor-remove-button" src="/root/icons/remove-grey.svg" alt="Удалить">
        </div>
    </div>
    <div class="code-editor-content">
        <textarea class="content-area" rows="2">// Это поле, в которое вы можете добавить программный код.\n// Большое количество строк стоит разделить его на несколько секций.</textarea>
    </div>
</div>`;


const noteEditor = `<div class="note-editor editor">
    <div class="note-editor-header">
        <div class="buttons-container">
            <img class="editor-button add-link-button" src="/root/icons/link-purple.svg" alt="Вставить ссылку" />
            <div class="link-item-container">
                <input class="href-input" type="text" placeholder="https://mysite.ru" />
                <img class="editor-button save-link-button" src="/root/icons/ok-purple.svg" alt="Добавить" />
                <img class="editor-button cancel-link-button" src="/root/icons/cancel-purple.svg" alt="Отменить" />
            </div>
        </div>
        <div class="remove-button-container">
            <img class="editor-remove-button" src="/root/icons/remove-purple.svg" alt="Удалить" />
        </div>
    </div>
    <div class="content-editable content-area" contenteditable="true">Это поле примечания, в которое можно добавить ссылку, например, на сайт <a href="https://www.microsoft.com/ru-ru">Майкрософт</a>.</div>
</div>`;