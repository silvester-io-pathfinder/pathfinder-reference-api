using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NegateDamage : Template
    {
        public static readonly Guid ID = Guid.Parse("227d7b00-069c-4603-a604-b85ff09cae1b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Negate Damage",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You would take damage.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b3155d8e-5764-4b99-adf7-8835b3f321a4"), Type = TextBlockType.Text, Text = "Your armor innovation activates various devices you prepared ahead of time, and you use one of them to reduce the damage you would take by 15." };
            yield return new TextBlock { Id = Guid.Parse("6370a594-3c2b-474a-a6dd-6596150c8a08"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("b76cda09-4f1a-434d-9c7b-9592f4a776d9"), Type = TextBlockType.Text, Text = "~ Unstable Function: You activate all the precautions at once, violently repelling the incoming attack to blunt its force. Add the (trait: unstable) trait to Negate Damage and reduce the damage you would take by 50." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("fd46eb21-8ffa-47bb-a908-7eb938785f17"), Innovations.Instances.Armor.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1aec83f1-2f9d-490f-82f9-1bc585da3454"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
