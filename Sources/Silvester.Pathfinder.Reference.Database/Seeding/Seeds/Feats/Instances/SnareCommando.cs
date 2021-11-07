using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SnareCommando : Template
    {
        public static readonly Guid ID = Guid.Parse("01141847-4796-4c03-a258-a9e76df99185");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Snare Commando",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature fails or critically fails a save against your snare.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("23e5aff4-83f8-44b0-b249-fcef613a11c2"), Type = TextBlockType.Text, Text = "Your snares are so befuddling that your victims rarely notice you slipping out of sight. If you have expert proficiency in Deception, you can (action: Create a Diversion) against the triggering creature. If you have expert proficiency in Intimidation, you can instead (action: Demoralize) the triggering creature. If you have both, choose one of the two effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("3d900360-d498-4b3f-ab6c-a9e635570081"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("255fed36-5214-4b11-a3b6-78b07022b1d0"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("ca126183-b323-4523-8688-b67c3ecf6c6a"), Proficiencies.Instances.Expert.ID, Skills.Instances.Intimidation.ID);
            });
            builder.HaveSpecificFeat(Guid.Parse("187657ba-cdaf-45eb-a9b0-fd30bea25678"), Feats.Instances.SnareCrafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e67c106b-7ba3-440d-b8ef-f2ee6b28e45f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
