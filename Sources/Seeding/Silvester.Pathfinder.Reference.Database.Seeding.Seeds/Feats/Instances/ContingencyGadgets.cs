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
    public class ContingencyGadgets : Template
    {
        public static readonly Guid ID = Guid.Parse("99c911e7-8d8f-4e73-b55b-f8e2a607cdf6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Contingency Gadgets",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("03774035-81d2-45dc-b0dd-f2bc494e063a"), Type = TextBlockType.Text, Text = $"You are too brilliant to be caught off guard, and you always have just the right gadget for the situation. When you prepare your gadgets during your daily preparations, you can choose to leave one of them as a contingency gadget that you keep ready for just this situation, rather than declaring which gadget you're making. You can pull the contingency gadget out using an {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} action, at which point you must choose which gadget you had prepared as a contingency." };
            yield return new TextBlock { Id = Guid.Parse("bb5f55c7-b2da-43d2-bdfb-28e67a9b9adc"), Type = TextBlockType.Text, Text = $"If you're legendary in Crafting, you can leave two contingency gadgets during your daily preparations, instead of just one." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8af898e6-8638-499a-9fb5-f003378b0a17"), Feats.Instances.GadgetSpecialist.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Inventor.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2c054c2-1315-4dd5-8140-cc4f490401eb"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
