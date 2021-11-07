using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SparkFist : Template
    {
        public static readonly Guid ID = Guid.Parse("a75a198b-d0d5-41f8-8308-008a15ef3818");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spark Fist",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e4612867-0f9d-4ac9-81fb-3743aa0ce7a0"), Type = TextBlockType.Text, Text = "~ Access: You are from Dongun Hold or Alkenstar." };
            yield return new TextBlock { Id = Guid.Parse("83eea6db-a4bf-4df8-8cf4-078718c97f9c"), Type = TextBlockType.Text, Text = "You dust explosive black powder on your fist or glove before attacking, which combusts as you hit an opponent. The resulting pops of flame harm both you and your enemy. Until the end of your next turn, your fist loses the (trait: nonlethal) trait and deals an additional 1 fire damage on a successful (action: Strike). Each time you succeed on a fist (action: Strike), you take 1 fire damage. If your fist would deal more than one weapon damage die, the fire damage dealt on a successful (action: Strike), to both you and your opponent, is equal to the number of weapon damage dice." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("d102c624-dad1-49db-b423-f858fdd35c47"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f6b5282d-a889-4b17-91d2-a81c03b0b2e5"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
