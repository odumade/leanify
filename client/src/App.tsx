import { useEffect, useState } from 'react';
import type { Course } from './types/Course';
import { api } from './services/api';

function App() {
  const [courses, setCourses] = useState<Course[]>([]);

  useEffect(() => {
    api.get<Course[]>('/Courses')
      .then(response => setCourses(response.data))
      .catch(error => console.error('Error fetching courses:', error));
  }, []);

  return (
    <div style={{ padding: '2rem' }}>
      <h1>Course List</h1>
      <ul>
        {courses.map(course => (
          <li key={course.id}>
            <strong>{course.title}</strong> – ${course.price} – Instructor: {course.instructor}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;
