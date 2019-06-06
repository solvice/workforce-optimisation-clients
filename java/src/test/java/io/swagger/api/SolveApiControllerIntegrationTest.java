package io.swagger.api;

import io.swagger.model.Error;
import io.swagger.model.InlineResponse400;
import io.swagger.model.ShiftRequest;
import io.swagger.model.StatusJob;

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
public class SolveApiControllerIntegrationTest {

    @Autowired
    private SolveApi api;

    @Test
    public void solveShiftProblemTest() throws Exception {
        ShiftRequest body = new ShiftRequest();
        Integer seconds = 56;
        ResponseEntity<StatusJob> responseEntity = api.solveShiftProblem(body, seconds);
        assertEquals(HttpStatus.NOT_IMPLEMENTED, responseEntity.getStatusCode());
    }

    @Test
    public void solveTaskTest() throws Exception {
        Integer seconds = 56;
        ResponseEntity<StatusJob> responseEntity = api.solveTask(seconds);
        assertEquals(HttpStatus.NOT_IMPLEMENTED, responseEntity.getStatusCode());
    }

}
