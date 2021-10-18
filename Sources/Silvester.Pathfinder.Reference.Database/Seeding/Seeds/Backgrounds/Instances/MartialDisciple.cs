using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class MartialDisciple : Template
    {
        public static readonly Guid ID = Guid.Parse("19ee9a31-1b65-4dc3-b7cf-5e11827401e2");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Martial Disciple",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("cce853eb-b6d3-4130-bb12-030230c77f4b"), Type = TextBlockType.Text, Text = "You dedicated yourself to intense training and rigorous study to become a great warrior. The school you attended might have been a traditionalist monastery, an elite military academy, or the local branch of a prestigious mercenary organization." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("d9b0c8d7-18cc-4a0e-b494-3e42565d724f"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("99d2df9a-db0f-4fe8-a4a4-148d74df8fb8"), StatId = Stats.Instances.Strength.ID },
                    new StatEffectBinding{Id = Guid.Parse("664c895d-509b-45a1-bcdd-15eb76f529f3"), StatId = Stats.Instances.Dexterity.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("a4c9ffdb-b4b1-4e7a-b42d-a74adb7072df")
            };

            yield return new ChoiceEffect
            {
                Id = Guid.Parse("ed6f453a-e585-438b-b537-716a7503bf35"),
                Choices = new Effect[]
                {
                    new CombinedEffect
                    {
                        Id = Guid.Parse("ce2e1ca2-df03-4653-8e80-f8ddb9e0debd"),
                        Entries = new Effect[]
                        {
                            new GainSpecificSkillProficiencyEffect { Id = Guid.Parse("70b0a523-8215-4fb4-83ce-5fe2be0828af"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Acrobatics.ID },
                            new GainSpecificFeatEffect { Id = Guid.Parse("6169ffde-b95e-4750-8881-d4151a5dadee"), FeatId = Feats.General.CatFallFeat.ID }
                        }
                    },
                    new CombinedEffect
                    {
                        Id = Guid.Parse("ac1fc23c-87f3-45e2-a488-aa17b1e68cc7"),
                        Entries = new Effect[]
                        {
                            new GainSpecificSkillProficiencyEffect { Id = Guid.Parse("b23fbbb8-ed60-4587-96fb-2ba4d6c6e316"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Athletics.ID },
                            new GainSpecificFeatEffect { Id = Guid.Parse("15047104-9e98-43da-b5be-4912b3f7bbef"), FeatId = Feats.General.QuickJumpFeat.ID }
                        }
                    }
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d2cb128-d0cf-4c92-a5fb-90ca9c98a73e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 63
            };
        }
    }
}
