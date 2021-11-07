using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TweakAppearances : Template
    {
        public static readonly Guid ID = Guid.Parse("f5f98ab9-a484-4132-80c6-c226af929e57");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tweak Appearances",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7265d1be-0402-4aa1-bc80-f508fccf5214"), Type = TextBlockType.Text, Text = "~ Access: Have earnt Mialari Docur’s trust and have proven their worth by defeating the Scarlet Triad." };
            yield return new TextBlock { Id = Guid.Parse("f49bedba-262c-4cdf-aed8-18e8ad011c6e"), Type = TextBlockType.Text, Text = "You spend 1 minute making quick adjustments to someone’s clothing and appearance, causing their words to carry more weight with an audience of your choice." };
            yield return new TextBlock { Id = Guid.Parse("fedd7580-7cdc-4836-b3e3-128b5d31879a"), Type = TextBlockType.Text, Text = "While speaking to that audience, the target gains a +1 item bonus to Diplomacy and Performance checks. If you have master proficiency in Crafting, the bonus increases to +2; if you have legendary proficiency in Crafting, the bonus increases to +3. This bonus lasts until this ability is used on the target again, the situation they were prepared for ends, or they next change their outfit." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("b2535a48-c535-44f8-952c-a392f248c9cd"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f206bba-cbf4-4e43-8670-fa5a1c1d97a3"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
