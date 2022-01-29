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
    public class WardMedic : Template
    {
        public static readonly Guid ID = Guid.Parse("c02d68f1-2d08-4df8-aa21-1d5c4d09fe83");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ward Medic",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bf2d306c-e31a-4f9a-8d79-8e62a093f7dc"), Type = TextBlockType.Text, Text = $"You've studied in large medical wards, treating several patients at once and tending to all their needs. When you use {ToMarkdownLink<Models.Entities.SkillAction>("Treat Disease", SkillActions.Instances.TreatDisease.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Treat Wounds", SkillActions.Instances.TreatWounds.ID)}, you can treat up to two targets. If you're a master in Medicine, you can treat up to four targets, and if you're legendary, you can treat up to eight targets." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("1323441e-3d33-4ca2-971d-d923c3f8d5f5"), Proficiencies.Instances.Expert.ID, Skills.Instances.Medicine.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("01351092-f70b-462f-af98-0ea04001ca7f"), Traits.Instances.General.ID);
            builder.Add(Guid.Parse("7a2ad5ec-ec2b-4842-be5b-8bd66468f771"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a792524-5272-4ac2-bd37-04006fb499be"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
