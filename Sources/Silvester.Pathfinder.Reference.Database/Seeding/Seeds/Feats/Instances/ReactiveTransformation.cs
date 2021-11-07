using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReactiveTransformation : Template
    {
        public static readonly Guid ID = Guid.Parse("c210c63e-9343-4a45-949c-a98de848b2a1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reactive Transformation",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "varies",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1e73dab3-04aa-4930-9c1b-58274a2a4224"), Type = TextBlockType.Text, Text = "You transform reflexively when in danger. You cast (spell: wild shape) to transform into one form granted by one of the prerequisite feats you have, depending on the trigger. Your form’s resistances and weaknesses apply against the triggering damage." };
            yield return new TextBlock { Id = Guid.Parse("2a8ed47b-d02a-4522-8d86-60b4e34be1f0"), Type = TextBlockType.Enumeration, Text = " Trigger: You fall 10 feet or more; Effect: Choose a form from (spell: aerial form)." };
            yield return new TextBlock { Id = Guid.Parse("b6608d42-7b2c-4c11-8b1d-7215a1b682ce"), Type = TextBlockType.Enumeration, Text = " Trigger: You take acid, cold, electricity, fire, or poison damage; Effect: Choose a form from (spell: dragon form) that resists the triggering damage." };
            yield return new TextBlock { Id = Guid.Parse("11b3b2e5-f434-4980-a447-4650deb4246c"), Type = TextBlockType.Enumeration, Text = " Trigger: You take fire damage; Effect: Choose a fire elemental form from (spell: elemental form)." };
            yield return new TextBlock { Id = Guid.Parse("92cab788-6943-4bae-9a95-830f6cacd845"), Type = TextBlockType.Enumeration, Text = " Trigger: You take poison damage; Effect: Choose a form from (spell: plant form)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("74b62657-b5fe-4862-a3dc-0ddf2140db91"), Feats.Instances.WildShape.ID);
            builder.AddOr(Guid.Parse("8d3b96f1-7599-4b0b-82e0-ed212ef664a2"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("796958f2-f1de-477b-8c40-aac45e6fd163"), Feats.Instances.DragonShape.ID);
                or.HaveSpecificFeat(Guid.Parse("9d86568c-5ad9-41f5-aabe-a24bf8094a4d"), Feats.Instances.ElementalShape.ID);
                or.HaveSpecificFeat(Guid.Parse("eba5918e-a634-40a5-981c-4233fdce72a9"), Feats.Instances.PlantShape.ID);
                or.HaveSpecificFeat(Guid.Parse("34fe4e8d-0da8-4dd9-b606-1f11601a041b"), Feats.Instances.SoaringShape.ID);
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
                Id = Guid.Parse("e444ca57-1a24-401b-a788-e56ac365cb7b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
