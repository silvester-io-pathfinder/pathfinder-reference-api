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
    public class SchooledInSecrets : Template
    {
        public static readonly Guid ID = Guid.Parse("4a23ef0a-4d7a-498a-a083-2a461d23b098");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Schooled in Secrets",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("df659085-f5e3-4edd-95b0-87058c30ed16"), Type = TextBlockType.Text, Text = $"You notice the signs and symbols that members of mystery cults and other secret societies use to declare their affiliation to fellow members. You can use Occultism in place of Diplomacy to {ToMarkdownLink<Models.Entities.SkillAction>("Gather Information", SkillActions.Instances.GatherInformation.ID)} about such groups. If you belong to a secret cult, lodge, sect, or similar organization, you automatically recognize members of your group unless they are specifically attempting to conceal their presence from you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("101f6f0d-c22f-4dd8-a82f-3d9c31a2d1c1"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("661391c5-ae1c-4af7-aa9b-f88717e815b6"), Traits.Instances.General.ID);
            builder.Add(Guid.Parse("a67c0377-e274-4e62-bfc7-4bbf4da5a426"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a406f263-e8a2-4fc6-8c40-b62bdd6e3a30"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
