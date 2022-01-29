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
    public class EsotericPolymath : Template
    {
        public static readonly Guid ID = Guid.Parse("44d8ff2a-0f20-43e9-ad22-c41d18e200d0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Esoteric Polymath",
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
            yield return new TextBlock { Id = Guid.Parse("9101d048-c225-49e4-aef4-5c9633efb137"), Type = TextBlockType.Text, Text = $"You keep a book of occult spells, similar to a wizard's {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("spellbook", Items.AdventuringGears.Instances.Spellbook.ID)}, and can use its spells to supplement your spell repertoire. Add all the spells in your repertoire to this book for free. You can use the Occultism skill to {ToMarkdownLink<Models.Entities.SkillAction>("Learn Spells", SkillActions.Instances.LearnASpell.ID)} and add them to your {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("spellbook", Items.AdventuringGears.Instances.Spellbook.ID)} by paying the appropriate cost, similar to a wizard." };
            yield return new TextBlock { Id = Guid.Parse("27c003fd-bf33-4626-bd80-24dfd2ea11ad"), Type = TextBlockType.Text, Text = $"During your daily preparations, choose any one spell from your book of occult spells. If that spell is already in your spell repertoire, you can treat it as an additional signature spell that day. If it isn't in your repertoire, treat it as though it were until your next daily preparations." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("60e6f2c0-ade9-4988-9794-ea676794efb5"), Muses.Instances.Polymath.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Bard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a443cf4c-b5e9-491b-9a1b-b9468e51fc3c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
