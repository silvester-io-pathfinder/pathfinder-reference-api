using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReactiveTransformation : Template
    {
        public static readonly Guid ID = Guid.Parse("cad87e02-afd7-44b0-9ac5-d76ab4dabe6a");

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
            yield return new TextBlock { Id = Guid.Parse("04c5d18b-53ee-43b5-9a8f-aae7b3380398"), Type = TextBlockType.Text, Text = "You transform reflexively when in danger. You cast (spell: wild shape) to transform into one form granted by one of the prerequisite feats you have, depending on the trigger. Your form's resistances and weaknesses apply against the triggering damage." };
            yield return new TextBlock { Id = Guid.Parse("5e3f7fe9-5592-42a6-8c9d-78bfa46cc465"), Type = TextBlockType.Enumeration, Text = " Trigger: You fall 10 feet or more; Effect: Choose a form from (spell: aerial form)." };
            yield return new TextBlock { Id = Guid.Parse("9cbe79dd-0010-4fce-a1de-0065bef06193"), Type = TextBlockType.Enumeration, Text = " Trigger: You take acid, cold, electricity, fire, or poison damage; Effect: Choose a form from (spell: dragon form) that resists the triggering damage." };
            yield return new TextBlock { Id = Guid.Parse("f19a2d4d-6c9d-4d94-91c0-c615c80b3f43"), Type = TextBlockType.Enumeration, Text = " Trigger: You take fire damage; Effect: Choose a fire elemental form from (spell: elemental form)." };
            yield return new TextBlock { Id = Guid.Parse("289f17db-dc0c-4c3d-bd34-3a4e32b99501"), Type = TextBlockType.Enumeration, Text = " Trigger: You take poison damage; Effect: Choose a form from (spell: plant form)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("90fb62db-d9e0-4e86-8451-21ae85888d64"), Feats.Instances.WildShape.ID);
            builder.AddOr(Guid.Parse("ec03bfaa-ac49-4067-9b9f-2e049c106eef"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("eb5dff5f-f689-45b1-9301-824b2f5bacf0"), Feats.Instances.DragonShape.ID);
                or.HaveSpecificFeat(Guid.Parse("3ad40d06-d108-4f7a-b1f9-409f1f518453"), Feats.Instances.ElementalShape.ID);
                or.HaveSpecificFeat(Guid.Parse("53491f83-7d46-420f-9c89-bbd2608a607e"), Feats.Instances.PlantShape.ID);
                or.HaveSpecificFeat(Guid.Parse("049c261c-167b-4dcc-8b60-86c4788ec41d"), Feats.Instances.SoaringShape.ID);
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
                Id = Guid.Parse("a0f19fd9-c222-4443-b4ff-15f0687d0931"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
