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
    public class RevealMachinations : Template
    {
        public static readonly Guid ID = Guid.Parse("ccdaedb3-1dbd-40d0-9ba9-0e12e9568d9a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reveal Machinations",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "At the GM's discretion, this feat can be used against non-humanoids if they have regular contact with humanoids or you are able to disguise yourself as a member of the target's ancestry or type of creature.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("93fe0399-40cb-4da1-b75d-c2e86ae466d5"), Type = TextBlockType.Text, Text = $"~ Access: Have earnt Mialari Docur's trust and have proven their worth by defeating the Scarlet Triad." };
            yield return new TextBlock { Id = Guid.Parse("9ad6ce12-83ee-49f4-afaf-5151a8cbbd1f"), Type = TextBlockType.Text, Text = $"You reveal that you played a minor but recurring role in another humanoid's life – or at least convince them that's the case. Attempt a Deception check against the target's Will DC. On a success, the revelation makes them frightened 2, and on a critical success they are frightened 3. In addition, you gain information about the subject as though you had attempted to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} about them using an appropriate skill and received the same result on your roll. You can't use this ability against the same humanoid again until 1 day has passed and you've also successfully disguised yourself as a different person." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e6d05509-22c0-4467-b2ea-cb899d466f35"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Deception.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.General.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3eb96720-ee69-447e-9197-87eef10cfd4f"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
