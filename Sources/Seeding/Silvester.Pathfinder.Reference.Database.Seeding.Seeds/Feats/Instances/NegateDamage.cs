using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NegateDamage : Template
    {
        public static readonly Guid ID = Guid.Parse("55c6bc00-75c2-406e-80fa-46bc813591a2");

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
            yield return new TextBlock { Id = Guid.Parse("81b9d5d9-5637-4495-80f9-a5c3f94deac0"), Type = TextBlockType.Text, Text = $"Your armor innovation activates various devices you prepared ahead of time, and you use one of them to reduce the damage you would take by 15." };
            yield return new TextBlock { Id = Guid.Parse("00f24a30-c72d-441d-bde3-c2fc20596050"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("e74b97a6-2b80-4eaf-8753-56b902e1d862"), Type = TextBlockType.Text, Text = $"~ Unstable Function: You activate all the precautions at once, violently repelling the incoming attack to blunt its force. Add the {ToMarkdownLink<Models.Entities.Trait>("unstable", Traits.Instances.Unstable.ID)} trait to Negate Damage and reduce the damage you would take by 50." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("37516aea-123d-419b-bf09-f1d354c57ffe"), Innovations.Instances.Armor.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0e47d456-9232-44b9-b262-407b8ac4664f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
