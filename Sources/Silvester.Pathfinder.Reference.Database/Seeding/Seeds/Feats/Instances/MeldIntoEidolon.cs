using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MeldIntoEidolon : Template
    {
        public static readonly Guid ID = Guid.Parse("f8b49ded-f5a5-452d-861e-e1ed0e3760c8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Meld into Eidolon",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4d1fcd3f-bbdf-465a-ac65-28b68ee96eac"), Type = TextBlockType.Text, Text = "Your physical form can combine with that of your eidolon, granting benefits but limiting your capabilities. You (action: Manifest your Eidolon | Manifest Eidolon), but instead of summoning it into an adjacent open space, you become it. While Manifested in this way, you use its statistics, and you can’t act except to direct it to use (action: Manifest an Eidolon | Manifest Eidolon) to unmanifest it." };
            yield return new TextBlock { Id = Guid.Parse("4b423f43-c2c3-42fa-8e19-c424bb09a27e"), Type = TextBlockType.Text, Text = "Since you can’t act, you can’t (action: Cast Spells | Cast a Spell), activate or benefit from magic items that normally benefit you and not your eidolon, perform actions that have the (trait: tandem) trait, or use other abilities that require you, and not the eidolon, to act. Your can’t be separately targeted while you are melded into it. When you reach 0 HP, your eidolon unmanifests, leaving your body behind, unconscious and dying." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("65aa49f4-7264-405b-8857-3314c9b94548"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
