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
    public class AldoriDuelistDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("d4a0a4fe-b6fd-46b0-8b79-7440456fdf3d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aldori Duelist Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the Aldori duelist archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f7926a84-66bf-4a97-8077-56e27c898fc1"), Type = TextBlockType.Text, Text = $"~ Access: You are from the Broken Lands region." };
            yield return new TextBlock { Id = Guid.Parse("4c178599-e984-46e8-84a8-e8c8e88a5ae2"), Type = TextBlockType.Text, Text = $"Your Aldori duelist training teaches you martial techniques and increases your dedication to the Aldori dueling sword. You become trained in your choice of Acrobatics or Athletics and in Dueling Lore; if you were already trained, you become an expert instead. Whenever your proficiency rank in any weapon increases to expert or beyond, you also gain that new proficiency rank with Aldori dueling swords. You gain access to Aldori dueling swords." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMeleeWeaponSpecificProficiency(Guid.Parse("57b1569f-b038-46b5-90c1-ee55622700ee"), Proficiencies.Instances.Trained.ID, Items.MeleeWeapons.Instances.AldoriDuelingSword.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("be625fbf-2e66-4ccb-89e1-9411a850d83d"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("bb138d2a-1010-4e6a-bb91-70c4dbed590c"), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("259191a5-af47-41e1-9ec1-9452750c7f4f"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
