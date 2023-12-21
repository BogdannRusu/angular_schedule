from fastapi import FastAPI
app = FastAPI()

@app.get("/")
def red_something():
    return{"msg": " Hello Bogdan "}