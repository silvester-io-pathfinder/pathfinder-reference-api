using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TasteBlood : Template
    {
        public static readonly Guid ID = Guid.Parse("9c1ab76f-0d48-4ce4-91fd-0346b315072d");

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
            yield return new TextBlock { Id = Guid.Parse("366ba6d6-3e3f-46da-a0ea-8dac19f4c28f"), Type = TextBlockType.Text, Text = "You retain not only your vampiric parent’s taste for blood but their ability to gain vitality from it. You drink fresh blood from a living humanoid creature, gaining temporary Hit Points equal to the target’s level that last for 10 minutes. The target must succeed at a Fortitude save against the higher of your class DC or spell DC or become drained 1. Regardless of the outcome of this save, the target is temporarily immune to your Taste Blood for 1 day; further uses of this ability against the target don’t increase the drained condition or grant you more temporary Hit Points." };
            yield return new TextBlock { Id = Guid.Parse("a1f4e772-520b-47b2-98aa-dbd979224276"), Type = TextBlockType.Text, Text = "To drink a creature’s blood, either your last action must have been a fangs (action: Strike) that damaged the target, or the target must be restrained or unconscious and your last action must have been a (action: Strike) that dealt piercing or slashing damage to them. If the target is willing, they don’t need to be restrained or unconscious for the latter." };
            yield return new TextBlock { Id = Guid.Parse("10327330-655a-498b-ac75-174050853e85"), Type = TextBlockType.Text, Text = "Draining the life force from an unwilling humanoid creature is a greater violation than just drinking their blood. Taste Blood has the (trait: evil) trait unless the target is willing or is an active foe in combat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("07c03156-0698-4695-aeaf-437a48c939e2"), "Cel Rau, Straveika, Svetocher, or another lineage from a vampire with the Drink Blood ability.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec3e4748-6d19-4252-a27e-021b27c57a5a"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
