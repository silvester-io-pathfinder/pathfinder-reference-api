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
    public class ReadShibboleths : Template
    {
        public static readonly Guid ID = Guid.Parse("3569b2d4-a302-4f1d-a728-f0224d772f44");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Read Shibboleths",
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
            yield return new TextBlock { Id = Guid.Parse("f5e5683f-ea1e-4241-bbee-e997d8d341a9"), Type = TextBlockType.Text, Text = $"All communication is filled with slight tells and signals. If you interact with someone for at least 10 minutes, their regional words, pronunciation changes, and nonverbal cues provide you with a minor fact about their social environment, such as their hometown or certain groups they might belong to. If a target of this ability is being deceptive about their social environment, such as a commoner pretending to be a noble, they must attempt a Deception, Society, or appropriate Lore check against your Society DC, providing you a false minor fact consistent with their assumed identity on a success." };
            yield return new TextBlock { Id = Guid.Parse("359db840-a757-4a70-8812-5a3ecda03754"), Type = TextBlockType.Text, Text = $"Once you've gleaned one or more true minor facts about a person, you can then incorporate these mannerisms into your speech to present yourself in a way that they find familiar. This grants you a +1 circumstance bonus to your Diplomacy and Deception checks with them." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c9b80502-0be4-4db6-9f13-9e417fb42a0e"), Feats.Instances.LinguistDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("a94c97f8-7aa6-4c98-8ae7-1eb78c70073e"), Proficiencies.Instances.Master.ID, Skills.Instances.Society.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Linguistic.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7a811ac8-2db6-4291-9943-221a260fb02e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
