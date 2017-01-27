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
const todo_1 = require('./todo');
const todo_data_service_1 = require('./todo-data.service');
let AppComponent = class AppComponent {
    constructor(todoDataService) {
        this.todoDataService = todoDataService;
        this.newTodo = new todo_1.Todo();
    }
    addTodo() {
        this.todoDataService.addTodo(this.newTodo);
        this.newTodo = new todo_1.Todo();
    }
    toggleTodoComplete(todo) {
        this.todoDataService.toggleTodoComplete(todo);
    }
    removeTodo(todo) {
        this.todoDataService.deleteTodoById(todo.id);
    }
    get todos() {
        return this.todoDataService.getAllTodos();
    }
};
AppComponent = __decorate([
    core_1.Component({
        selector: 'app-root',
        templateUrl: './app/app.component.html',
        styleUrls: ['./app/app.component.css'],
        providers: [todo_data_service_1.TodoDataService]
    }), 
    __metadata('design:paramtypes', [todo_data_service_1.TodoDataService])
], AppComponent);
exports.AppComponent = AppComponent;
//# sourceMappingURL=app.component.js.map