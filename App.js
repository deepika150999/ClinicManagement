import { useState } from "react";

const App = () => {
  const [text, setText] = useState("");
  const [number, setNumber] = useState("");
  const [error, setError] = useState("");
  const [todos, setTodos] = useState([
    { id: 1, name: "Deepika", phnumber: 9087654321 },
    { id: 2, name: "Arun", phnumber: 9807654321 },
  ]);
  const removeTodo = (id) => {
    let newTodos = todos.filter((todo) => todo.id !== id);
    setTodos(newTodos)
  };

  const addTodo = () => {
    if (text.length <= 0) {
      setError("Item cannot be empty");
    } else {
      setTodos([...todos, { id: todos.length + 1, name: text, phnumber: number }]);
      setText("");
      setNumber("");
      setError("");
    }
  };
  return (

    <>
      <h1>Name &Contact Number </h1>
      <p>
        <label>Enter Your name</label>
        <input type="text"
          value={text}
          onChange={(event) => {
            setText(event.target.value);
          }} />
      </p>
      <p>
        <label>Enter YourPhone Number</label>
        <input type="number"
          value={number}
          onChange={(e) => {
            setNumber(e.target.value);
          }} />
      </p>
      <button onClick={() => addTodo()}>ADD</button>
      <h3>Todo name</h3>
      {todos.map((todo) => {
        return (
          <p key={todo.id}>
            {todo.name}
            <span>
              <button onClick={() => removeTodo(todo.id)}>Remove</button>
            </span>
          </p>
        );
      })}
      <h3>Todo number</h3>
      {todos.map((todo) => {
        return (
          <p key={todo.id}>
            {todo.phnumber}
            <span>
              <button onClick={() => removeTodo(todo.id)}>Remove</button>
            </span>
          </p>
        );
      })}
    </>
  )
}
export default App;
