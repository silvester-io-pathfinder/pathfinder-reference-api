using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Spellstrike : Template
    {
        public static readonly Guid ID = Guid.Parse("f1df3dd3-14bc-4c5d-9227-695a1761905c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spellstrike",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "until recharged"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f750e13c-6352-4b9e-8e30-89870a054a06"), Type = TextBlockType.Text, Text = $"You channel a spell into a punch or sword thrust to deliver a combined attack. You {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} that takes 1 or 2 actions to cast and requires a spell attack roll. The effects of the spell don't occur immediately but are imbued into your attack instead. Make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with a weapon or unarmed attack. Your spell is coupled with your attack, using your attack roll result to determine the effects of both the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} and the spell. This counts as two attacks for your multiple attack penalty, but you don't apply the penalty until after you've completed the Spellstrike. The infusion of spell energy grants your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} the {ToMarkdownLink<Models.Entities.Trait>("arcane", Traits.Instances.Arcane.ID)} trait, making it magical." };
            yield return new TextBlock { Id = Guid.Parse("af606273-03d0-4887-9b1c-dac98286c34e"), Type = TextBlockType.Text, Text = $"After you use Spellstrike, you can't do so again until you recharge your Spellstrike as a single action, which has the {ToMarkdownLink<Models.Entities.Trait>("concentrate", Traits.Instances.Concentrate.ID)} trait. You also recharge your Spellstrike when you cast a conflux spell that takes at least 1 action to cast; casting a focus spell of another type doesn't recharge your Spellstrike." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bb1c1091-fb56-43f5-9cb8-a603b5926f64"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
