export class Recommendation {

    constructor(
public  recommendationId?: number,
public  UserId?:number,
public  Professional?: number, 
public  RecommendationDate?: Date,
public  IsEnable?: boolean,
public  RatePrice?: number,
public  RateProfessionalism?: number,
public  RateArrival?: number,
public Comments?:  string 
    ){}
}
