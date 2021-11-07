using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TasteBlood : Template
    {
        public static readonly Guid ID = Guid.Parse("b66d9c70-cdd0-44b2-b777-6a884173df17");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Taste Blood",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f7be9525-9936-4d82-a5f9-24c0a2355384"), Type = TextBlockType.Text, Text = "You retain not only your vampiric parent’s taste for blood but their ability to gain vitality from it. You drink fresh blood from a living humanoid creature, gaining temporary Hit Points equal to the target’s level that last for 10 minutes. The target must succeed at a Fortitude save against the higher of your class DC or spell DC or become drained 1. Regardless of the outcome of this save, the target is temporarily immune to your Taste Blood for 1 day; further uses of this ability against the target don’t increase the drained condition or grant you more temporary Hit Points." };
            yield return new TextBlock { Id = Guid.Parse("5082037b-f90f-484f-9bb8-b436197db56a"), Type = TextBlockType.Text, Text = "To drink a creature’s blood, either your last action must have been a fangs (action: Strike) that damaged the target, or the target must be restrained or unconscious and your last action must have been a (action: Strike) that dealt piercing or slashing damage to them. If the target is willing, they don’t need to be restrained or unconscious for the latter." };
            yield return new TextBlock { Id = Guid.Parse("474cb55b-9386-48ea-82a9-7b6bcd7f1a83"), Type = TextBlockType.Text, Text = "Draining the life force from an unwilling humanoid creature is a greater violation than just drinking their blood. Taste Blood has the (trait: evil) trait unless the target is willing or is an active foe in combat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("27ea248e-0858-4e8f-9938-0f9f4854e2f6"), "Cel Rau, Straveika, Svetocher, or another lineage from a vampire with the Drink Blood ability.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cc9ccd8e-8ae3-44ea-b2c2-60760bc0069d"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
