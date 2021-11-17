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
    public class PolychromaticAnadi : Template
    {
        public static readonly Guid ID = Guid.Parse("2f877df2-45ef-4e3e-aacf-8f2b2ae0ed3e");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Polychromatic Anadi"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f41f40cd-aafe-4c24-8005-60335e4d80aa"), Type = TextBlockType.Text, Text = "Your body is covered with exceptionally colorful hairs that create vibrant, eye-catching patterns, some of which might even show in your human form. You become trained in Performance (or another skill if you were already trained in Performance), and you gain the Impressive Performance feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("576116ce-b2b2-4503-90ed-13950366dd64"), or =>
            {
                or.GainSpecificSkillProficiency(Guid.Parse("1fbb4791-dc51-490e-b321-2de3bf9778dc"), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
                or.GainAnySkillProficiency(Guid.Parse("2a32e692-a82e-47c8-a282-34a645542ec3"), Proficiencies.Instances.Trained.ID)
                    .AddPrerequisites(Guid.Parse("b214e16e-eba0-4669-bfce-247c6f83fe67"), prerequisites =>
                    {
                        prerequisites.HaveSpecificSkillProficiency(Guid.Parse("6962615e-0e94-42d2-b883-57b3bf91d434"), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
                    });
            });
            builder.GainSpecificFeat(Guid.Parse("be45681b-081a-468e-8fe0-f7af55938726"), Feats.Instances.ImpressivePerformance.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2a97e822-5357-4015-ae3d-55b7b527ae9a"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 103
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Anadi.ID;
        }
    }
}
