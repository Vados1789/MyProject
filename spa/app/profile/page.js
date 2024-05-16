'use client';

import React from 'react';
import { Box, Heading, Table, Thead, Tbody, Tr, Th, Td, Image } from '@chakra-ui/react';

function Profile({ profileData }) {
  return (
    <Box maxW="container.lg" mx="auto" mt={8} p={6} borderWidth="1px" borderRadius="lg">
      <Heading as="h2" size="xl" mb={4}>
        Profile
      </Heading>
      <Table variant="simple">
        <Thead>
          <Tr>
            <Th>First Name</Th>
            <Th>Last Name</Th>
            <Th>Email</Th>
            <Th>Address</Th>
            <Th>City</Th>
            <Th>Post Code</Th>
            <Th>Image</Th>
          </Tr>
        </Thead>
        <Tbody>
          <Tr>
            <Td>{profileData.first_Name}</Td>
            <Td>{profileData.last_Name}</Td>
            <Td>{profileData.email}</Td>
            <Td>{profileData.address}</Td>
            <Td>{profileData.city}</Td>
            <Td>{profileData.post_Code}</Td>
            <Td>
              <Image src={profileData.image} alt={`${profileData.first_Name} ${profileData.last_Name}`} boxSize="50px" />
            </Td>
          </Tr>
        </Tbody>
      </Table>
    </Box>
  );
}

export default Profile;