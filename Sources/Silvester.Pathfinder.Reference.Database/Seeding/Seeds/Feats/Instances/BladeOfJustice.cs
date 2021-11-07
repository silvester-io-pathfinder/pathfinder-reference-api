using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BladeOfJustice : Template
    {
        public static readonly Guid ID = Guid.Parse("15ab858c-6ef1-4204-b85c-783b5ac59199");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blade of Justice",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("35b562e6-fe50-4eea-84e4-f5fcc07d41cb"), Type = TextBlockType.Text, Text = "You call upon divine power and make a weapon or unarmed (action: Strike) against a foe you have witnessed harming an ally or innocent. The (action: Strike) deals two extra weapon damage dice if the target of your (action: Strike) is evil. Whether or not the target is evil, you can convert all the physical damage from the attack into good damage, and if you are a paladin, the (action: Strike) applies all effects that normally apply on a (feat: Retributive Strike) (such as divine smite)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e2e166f-9e5c-42cb-8dff-12a740553308"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
