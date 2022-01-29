using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnvironmentalGrace : Template
    {
        public static readonly Guid ID = Guid.Parse("ffce5b58-8429-4fb0-b97d-2f2f064d9408");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Environmental Grace",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("85f85fe7-7f81-44b0-afc4-cb0ef4c1dd4c"), Type = TextBlockType.Text, Text = $"You rapidly adapt to environments through a combination of skill, meditation, and divine grace. After spending an hour in an environment of severe cold or colder, you are protected from the effects of severe cold until you leave that environment. After spending an hour in an environment of severe heat or hotter, you are protected from the effects of severe heat until you leave that environment." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("cd60d83b-5b48-46f4-b787-4129ebedf566"), Proficiencies.Instances.Master.ID, Skills.Instances.Survival.ID);
            builder.AddOr(Guid.Parse("cef79a5e-d86c-4708-b48a-8e4948402216"), or => 
            {
                or.HaveAnyDeitySpecificDomain(Guid.Parse("4bdbd308-2c3b-4152-a2df-0130f0d856a5"), Domains.Instances.Cold.ID);
                or.HaveAnyDeitySpecificDomain(Guid.Parse("3c6b6972-e569-473c-9439-d1b7aada314d"), Domains.Instances.Fire.ID);
                or.HaveAnyDeitySpecificDomain(Guid.Parse("2f9a2861-cdd3-4035-9508-c908239e49ef"), Domains.Instances.Nature.ID);
                or.HaveAnyDeitySpecificDomain(Guid.Parse("b17da118-dd71-4c79-81fc-ff5120cecebf"), Domains.Instances.Travel.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("657d18b5-7da2-4520-b929-35d9ea51bf49"), Traits.Instances.General.ID);
            builder.Add(Guid.Parse("4d22546d-196a-4142-8087-71bb5dfb3adf"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("31ac3ec0-1e23-4484-a607-4e0182526232"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
