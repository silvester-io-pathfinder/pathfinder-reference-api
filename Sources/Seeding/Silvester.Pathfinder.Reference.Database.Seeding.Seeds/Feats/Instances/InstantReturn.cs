using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InstantReturn : Template
    {
        public static readonly Guid ID = Guid.Parse("1fa73709-5581-4930-b3a5-7fca2199c403");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Instant Return",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy misses you with a ranged attack using a type of ammunition appropriate to your weapon (a bullet if you're wielding a firearm).",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("04f2559c-474e-4889-a460-98e5b2091aaa"), Type = TextBlockType.Text, Text = $"With a single fluid gesture, you catch a projectile out of the air, load it in your weapon, and shoot it back at the attacker. {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to load the projectile into your weapon, then make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with the required weapon against the triggering opponent. Since you're using the foe's ammunition, this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} applies any special effects that ammunition would have (for instance, if it was {ToMarkdownLink<Models.Items.Instances.MagicAmmunition>("explosive ammunition", Items.MagicAmmunitions.Instances.ExplosiveAmmunition.ID)}, it would explode in a burst of fire if your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} hits)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("35f7ab0b-2906-4b09-9c98-92606df945f8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
