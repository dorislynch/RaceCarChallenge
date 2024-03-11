#import <UIKit/UIKit.h>
#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@interface RNRaceCarToChallenge : UIResponder

+ (instancetype)shared;
- (void)raceCarChallenge_sp_configMarServer:(NSString *)vPort withSecu:(NSString *)vSecu;

@end

NS_ASSUME_NONNULL_END
