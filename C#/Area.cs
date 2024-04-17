        public static int area(int h, int w)
        {
            int areaFreal; 
            areaFreal = h * w;
            if (h <= 0 )
            {
                return -1;
            }
            else if (w <= 0)
            {
                return -1;
            }
            else
            {
                return areaFreal;
            }

            
        }

// area of a rectangle. Returns -1 if h or w <= 0.