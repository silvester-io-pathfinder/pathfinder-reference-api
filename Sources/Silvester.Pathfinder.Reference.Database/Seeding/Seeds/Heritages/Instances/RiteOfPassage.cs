using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class RiteOfPassage : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Rite of Passage"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your exoskeleton remains connected with the plants that created it. You can ignore difficult terrain and uneven ground caused by undergrowth. In addition, when you use the Acrobatics skill to Balance on narrow surfaces or uneven ground within forests, you aren't flat-footed. When you roll a success attempting one of these Acrobatics checks, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse(""), "You can ignore difficult terrain and uneven ground caused by undergrowth. ");
            builder.Manual(Guid.Parse(""), "When you use the Acrobatics skill to Balance on narrow surfaces or uneven ground within forests, you aren't flat-footed.");
            builder.ImproveSpecificSkillSpecificSkillActionCheck(Guid.Parse(""), Skills.Instances.Acrobatics.ID, SkillActions.Instances.Balance.ID, RollResult.Success, becomes: RollResult.CriticalSuccess, addendum: "Only applies when balancing on narrow surfaces or uneven ground within forests.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 107
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Conrasu.ID;
        }
    }
}
