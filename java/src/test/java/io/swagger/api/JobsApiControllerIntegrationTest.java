package io.swagger.api;

import io.swagger.model.Error;
import io.swagger.model.ShiftSolution;
import io.swagger.model.StatusJob;
import java.util.UUID;

import java.util.*;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.test.context.junit4.SpringRunner;

import static org.junit.Assert.assertEquals;

@RunWith(SpringRunner.class)
@SpringBootTest
public class JobsApiControllerIntegrationTest {

    @Autowired
    private JobsApi api;

    @Test
    public void getSolutionTest() throws Exception {
        Long jobId = 789L;
        ResponseEntity<ShiftSolution> responseEntity = api.getSolution(jobId);
        assertEquals(HttpStatus.NOT_IMPLEMENTED, responseEntity.getStatusCode());
    }

    @Test
    public void getStatusTest() throws Exception {
        UUID jobId = new UUID();
        ResponseEntity<StatusJob> responseEntity = api.getStatus(jobId);
        assertEquals(HttpStatus.NOT_IMPLEMENTED, responseEntity.getStatusCode());
    }

}
