using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Spellstrike : Template
    {
        public static readonly Guid ID = Guid.Parse("47beb51e-f278-4c0d-9862-8670bf6f84f6");

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
            yield return new TextBlock { Id = Guid.Parse("45bb0c27-a027-4919-b5e3-81221dce59ff"), Type = TextBlockType.Text, Text = "You channel a spell into a punch or sword thrust to deliver a combined attack. You (action: Cast a Spell) that takes 1 or 2 actions to cast and requires a spell attack roll. The effects of the spell don’t occur immediately but are imbued into your attack instead. Make a melee (action: Strike) with a weapon or unarmed attack. Your spell is coupled with your attack, using your attack roll result to determine the effects of both the (action: Strike) and the spell. This counts as two attacks for your multiple attack penalty, but you don’t apply the penalty until after you’ve completed the Spellstrike. The infusion of spell energy grants your (action: Strike) the (trait: arcane) trait, making it magical." };
            yield return new TextBlock { Id = Guid.Parse("610eaa1f-1659-4d36-b648-56889afd5164"), Type = TextBlockType.Text, Text = "After you use Spellstrike, you can’t do so again until you recharge your Spellstrike as a single action, which has the (trait: concentrate) trait. You also recharge your Spellstrike when you cast a conflux spell that takes at least 1 action to cast; casting a focus spell of another type doesn’t recharge your Spellstrike." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ee4fe250-0ebe-47be-b0bb-bef70a1c0353"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
