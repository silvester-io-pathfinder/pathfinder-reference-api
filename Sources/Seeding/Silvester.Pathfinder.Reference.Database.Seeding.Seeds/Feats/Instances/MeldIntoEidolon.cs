using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MeldIntoEidolon : Template
    {
        public static readonly Guid ID = Guid.Parse("5f073f12-c6ad-4fab-9f23-5cd9cbc7588e");

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
            yield return new TextBlock { Id = Guid.Parse("bcccf9f6-103c-4d11-a0bf-fd05a13ac58d"), Type = TextBlockType.Text, Text = $"Your physical form can combine with that of your eidolon, granting benefits but limiting your capabilities. You {ToMarkdownLink<Models.Entities.Feat>("Manifest your Eidolon", Feats.Instances.ManifestEidolon.ID)}, but instead of summoning it into an adjacent open space, you become it. While Manifested in this way, you use its statistics, and you can't act except to direct it to use {ToMarkdownLink<Models.Entities.Feat>("Manifest an Eidolon", Feats.Instances.ManifestEidolon.ID)} to unmanifest it." };
            yield return new TextBlock { Id = Guid.Parse("f22a2079-73ac-4d59-84d0-c428195ec8e2"), Type = TextBlockType.Text, Text = $"Since you can't act, you can't {ToMarkdownLink<Models.Entities.Rule>("Cast Spells", Rules.Instances.CastASpell.ID)}, activate or benefit from magic items that normally benefit you and not your eidolon, perform actions that have the {ToMarkdownLink<Models.Entities.Trait>("tandem", Traits.Instances.Tandem.ID)} trait, or use other abilities that require you, and not the eidolon, to act. Your can't be separately targeted while you are melded into it. When you reach 0 HP, your eidolon unmanifests, leaving your body behind, unconscious and dying." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c6a7080-912b-4ad1-92a3-4b403dc8cbdd"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
