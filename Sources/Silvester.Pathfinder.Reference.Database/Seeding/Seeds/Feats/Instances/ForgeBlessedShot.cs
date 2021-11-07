using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ForgeBlessedShot : Template
    {
        public static readonly Guid ID = Guid.Parse("db8582ed-66ad-4b8b-8f57-363bd4da7e82");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Forge-Blessed Shot",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You attempt a ranged Strike.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e1a7bc31-293a-4963-b576-48681164b519"), Type = TextBlockType.Text, Text = "~ Access: You are from Dongun Hold or Alkenstar." };
            yield return new TextBlock { Id = Guid.Parse("1abdc57d-0263-4ea3-a4cf-168c63b2a855"), Type = TextBlockType.Text, Text = "You intone a prayer to the dwarven deities Torag or Angradd, willing a higher power to guide your aim in the heat of battle. On your next (action: Strike) with a ranged weapon before the end of your turn, you gain a +2 circumstance bonus to your attack roll and ignore your target’s concealed condition, as well as your target’s lesser, standard, and greater cover." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("b2d18b0f-f35b-42a2-9e24-52105a0d31bd"), or => 
            {
                or.WorshipSpecificDeity(Guid.Parse("4f58d058-d986-4ef9-9fbb-975f08005210"), Deities.Instances.Torag.ID);
                or.WorshipSpecificDeity(Guid.Parse("2c989eaf-e35b-4668-8d72-ec2cc8806b10"), Deities.Instances.Angradd.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a51b1e80-da8d-467d-a004-29cf6b004a7b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
