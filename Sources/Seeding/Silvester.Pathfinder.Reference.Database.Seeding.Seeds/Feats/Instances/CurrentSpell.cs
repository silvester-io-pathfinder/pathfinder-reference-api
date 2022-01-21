using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CurrentSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("49f2aa4c-58ac-4aac-88a5-e632d52b665c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Current Spell",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6bb74659-cefa-4819-a6f5-157364b5faa3"), Type = TextBlockType.Text, Text = $"As you use your magic to manipulate air or water, you divert some of its currents to form a barrier around you. If your next action is to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} with the {ToMarkdownLink<Models.Entities.Trait>("air", Traits.Instances.Air.ID)} or {ToMarkdownLink<Models.Entities.Trait>("water", Traits.Instances.Water.ID)} trait, until the start of your next turn, you gain a +1 circumstance bonus to AC or a +2 circumstance bonus against ranged attacks. This effect has the {ToMarkdownLink<Models.Entities.Trait>("air", Traits.Instances.Air.ID)} or {ToMarkdownLink<Models.Entities.Trait>("water", Traits.Instances.Water.ID)} trait, or both, depending on the traits of the spell you cast. You also gain a +1 circumstance bonus to all saves against effects with the {ToMarkdownLink<Models.Entities.Trait>("air", Traits.Instances.Air.ID)} trait, {ToMarkdownLink<Models.Entities.Trait>("water", Traits.Instances.Water.ID)} trait, or both until the start of your next turn, depending on the spell's traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cff074ea-fc2b-49be-a194-2933534848b3"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
