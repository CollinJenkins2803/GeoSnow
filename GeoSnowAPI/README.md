# GeoSnowAPI Documentation
![Nice Pic](https://valutrack.com/wp-content/uploads/2023/03/isa-cybersecurity-training-2-1.jpg)
## Newsletter APIs

### 1. Check Email Subscription

- **Purpose**: Checks if an email is subscribed to the newsletter.
- **Endpoint**: `GET /api/newsletter/check-subscription/{email}`
- **Input**: 
  - `email` (path parameter) - The email address to check.
- **Output**: 
  - `true` if the email is subscribed, `false` otherwise.

### 2. Add Subscriber

- **Purpose**: Adds a new subscriber to the newsletter.
- **Endpoint**: `POST /api/newsletter/add-subscriber`
- **Input**: 
  - `email` (body parameter) - The email address to add.
- **Output**: 
  - Success message if the email is added, error message otherwise.

### 3. Remove Subscriber

- **Purpose**: Removes a subscriber from the newsletter.
- **Endpoint**: `POST /api/newsletter/remove-subscriber`
- **Input**: 
  - `email` (body parameter) - The email address to remove.
- **Output**: 
  - Success message if the email is removed, error message otherwise.

## Forum APIs

### 4. Get Posts By Resort

- **Purpose**: Retrieves all forum posts associated with a specific resort.
- **Endpoint**: `GET /api/forum/posts-by-resort/{resortID}`
- **Input**: 
  - `resortID` (path parameter) - The ID of the resort.
- **Output**: 
  - A list of forum posts for the specified resort.

### 5. Add Forum Post

- **Purpose**: Adds a new post to the forum.
- **Endpoint**: `POST /api/forum/add-forum-post`
- **Input**: 
  - `resortID` (body parameter) - The ID of the resort.
  - `posterName` (body parameter) - The name of the poster.
  - `title` (body parameter) - The title of the post.
  - `content` (body parameter) - The content of the post.
  - `parentPostID` (body parameter, optional) - The ID of the parent post if it's a reply.
- **Output**: 
  - Success message if the post is added.

### 6. Delete Forum Post

- **Purpose**: Deletes a post from the forum.
- **Endpoint**: `DELETE /api/forum/delete-forum-post/{postID}`
- **Input**: 
  - `postID` (path parameter) - The ID of the post to delete.
- **Output**: 
  - Success message if the post is deleted.

