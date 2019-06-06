package io.swagger.api;

import io.swagger.model.Error;
import io.swagger.model.InlineResponse400;
import io.swagger.model.ShiftRequest;
import io.swagger.model.StatusJob;
import com.fasterxml.jackson.databind.ObjectMapper;
import io.swagger.annotations.*;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestHeader;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RequestPart;
import org.springframework.web.multipart.MultipartFile;

import javax.validation.constraints.*;
import javax.validation.Valid;
import javax.servlet.http.HttpServletRequest;
import java.io.IOException;
import java.util.List;
import java.util.Map;
@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.SpringCodegen", date = "2019-06-06T16:32:15.795+02:00[Europe/Brussels]")
@Controller
public class SolveApiController implements SolveApi {

    private static final Logger log = LoggerFactory.getLogger(SolveApiController.class);

    private final ObjectMapper objectMapper;

    private final HttpServletRequest request;

    @org.springframework.beans.factory.annotation.Autowired
    public SolveApiController(ObjectMapper objectMapper, HttpServletRequest request) {
        this.objectMapper = objectMapper;
        this.request = request;
    }

    public ResponseEntity<StatusJob> solveShiftProblem(@ApiParam(value = "Payload for all information concerning the shift problem.
This includes:

 - the demand
 - the pool of employees
 - the statutes
" ,required=true )  @Valid @RequestBody ShiftRequest body,@ApiParam(value = "The number of seconds you give the solver to optimise the SHIFT problem. By default, the solver decides.") @Valid @RequestParam(value = "seconds", required = false) Integer seconds) {
        String accept = request.getHeader("Accept");
        return new ResponseEntity<StatusJob>(HttpStatus.NOT_IMPLEMENTED);
    }

}
