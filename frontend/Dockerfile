### STAGE 1: Build ###
FROM node:lts-alpine AS build
WORKDIR /usr/src/app
COPY package*.json ./
RUN npm install -g @angular/cli && npm install
COPY . .
RUN npm run build --prod


### STAGE 2: Run ###
FROM nginx:alpine
COPY ./nginx.conf /etc/nginx/conf.d/default.conf
# Copiar los archivos de la build desde la etapa de compilación
COPY --from=build /usr/src/app/dist/frontend-hackathon/browser /usr/share/nginx/html
EXPOSE 8080
# Comando para ejecutar Nginx
CMD ["nginx", "-g", "daemon off;"]
