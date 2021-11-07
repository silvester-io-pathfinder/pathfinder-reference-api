using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DimensionalDisappearance : Template
    {
        public static readonly Guid ID = Guid.Parse("39b490da-aa5e-4af5-ba01-f2c09b486b89");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dimensional Disappearance",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b26255e5-b63d-4ca6-bf17-a7e662141efc"), Type = TextBlockType.Text, Text = "You take advantage of teleportation to better hide your position. When you cast (spell: dimensional assault), you’re affected by an (spell: invisibility) spell at the end of the teleport. You can choose not to make the (action: Strike) that is normally part of (spell: dimensional assault). If you do make the (action: Strike), your (spell: invisibility) ends after the (action: Strike), as normal for (spell: invisibility)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSpell(Guid.Parse("11f568e0-c008-46a5-9911-ea85adb058df"), Spells.Instances.DimensionalAssault.ID);
            builder.HaveSpecificHybridStudy(Guid.Parse("414e48be-b6a2-498d-9860-197795c2e31b"), HybridStudies.Instances.LaughingShadow.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("020cf525-ba01-48d4-a06c-a09941fb1667"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
