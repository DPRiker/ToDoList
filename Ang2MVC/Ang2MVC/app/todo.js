"use strict";
class Todo {
    constructor(values = {}) {
        this.title = '';
        this.complete = false;
        Object.assign(this, values);
    }
}
exports.Todo = Todo;
//# sourceMappingURL=todo.js.map