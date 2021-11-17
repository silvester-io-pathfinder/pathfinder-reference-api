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
    public class ImpersonatorAndroid : Template
    {
        public static readonly Guid ID = Guid.Parse("3b353b5f-be84-40e6-9266-614a87566fa4");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Impersonator Android"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b2c16114-2210-4d55-8deb-17b8769b28fd"), Type = TextBlockType.Text, Text = "Your body was augmented with processes and an appearance intended to blend in with humans more easily. You become trained in Deception (or another skill if you're already trained in Deception). You don't require a disguise kit when attempting Deception checks to Impersonate a human. In addition, you gain a +4 circumstance bonus to Impersonate checks to pretend that you're a human version of yourself, rather than an android. This bonus doesn't apply to other checks to Impersonate humans." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("3402e51f-31ac-4c20-aae6-e67f7db54aec"), or =>
            {
                or.GainSpecificSkillProficiency(Guid.Parse("728e0bd9-61b2-49dd-831f-bd288ffbd7d8"), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
                or.GainAnySkillProficiency(Guid.Parse("a633932b-0449-4727-85cd-c4ed5312e937"), Proficiencies.Instances.Trained.ID)
                    .AddPrerequisites(Guid.Parse("db9f5c73-3254-42ab-8e77-933a868c4450"), prerequisites =>
                    {
                        prerequisites.HaveSpecificSkillProficiency(Guid.Parse("4f2d334b-ab28-4c2f-a8b2-33a2ec7e3f4b"), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
                    });
            });
            builder.Manual(Guid.Parse("5de71b11-b5f9-4715-8636-fcfb1b6f7741"), "You don't require a disguise kit when attempting Deception checks to Impersonate a human.");
            builder.GainSpecificSkillActionCircumstanceBonus(Guid.Parse("3e72a1df-5bfc-46bc-be7d-496b9c8ee51b"), SkillActions.Instances.Impersonate.ID, bonus: 4, "Only applies to checks to pretend that you're a human version of yourself.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb599c59-e277-44c7-8cc8-fa98bcea4de2"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 71
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Android.ID;
        }
    }
}
