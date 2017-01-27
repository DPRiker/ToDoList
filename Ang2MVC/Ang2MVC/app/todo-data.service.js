"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
const core_1 = require('@angular/core');
let TodoDataService = class TodoDataService {
    constructor() {
        // Placeholder for last id so we can simulate
        // automatic incrementing of id's
        this.lastId = 0;
        // Placeholder for todo's
        this.todos = [];
    }
    // Simulate POST /todos
    addTodo(todo) {
        if (!todo.id) {
            todo.id = ++this.lastId;
        }
        this.todos.push(todo);
        return this;
    }
    // Simulate DELETE /todos/:id
    deleteTodoById(id) {
        this.todos = this.todos
            .filter(todo => todo.id !== id);
        return this;
    }
    // Simulate PUT /todos/:id
    updateTodoById(id, values = {}) {
        let todo = this.getTodoById(id);
        if (!todo) {
            return null;
        }
        Object.assign(todo, values);
        return todo;
    }
    // Simulate GET /todos
    getAllTodos() {
        return this.todos;
    }
    // Simulate GET /todos/:id
    getTodoById(id) {
        return this.todos
            .filter(todo => todo.id === id)
            .pop();
    }
    // Toggle todo complete
    toggleTodoComplete(todo) {
        let updatedTodo = this.updateTodoById(todo.id, {
            complete: !todo.complete
        });
        return updatedTodo;
    }
};
TodoDataService = __decorate([
    core_1.Injectable(), 
    __metadata('design:paramtypes', [])
], TodoDataService);
exports.TodoDataService = TodoDataService;
//# sourceMappingURL=todo-data.service.js.map